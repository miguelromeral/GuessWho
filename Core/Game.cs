using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Core
{
    public class Game
    {
        private Random _seed;
        public static int MAX_PLAYERS = 2;

        public List<User> Players { get; set; }
        protected int _turn;
        public int Turn
        {
            get
            {
                if (Players == null) return -1;

                return _turn % Players.Count;
            }
        }
        public bool GameReady
        {
            get
            {
                if (Players == null || Players.Count < 2)
                    return false;
                else
                    return true;
            }
        }
        public ILogger Logger;

        public User Winner
        {
            get
            {
                foreach (User u in Players)
                {
                    foreach (User r in Players)
                    {
                        if(u.Choosen != null && u.Name != r.Name && u.Choosen.Name == r.Secret.Name)
                            return u;
                    }
                }
                return null;
            }
        }
        public bool Finished { get { return Winner != null; } }

        public bool HumanTurn
        {
            get
            {
                if (Players == null)
                    return false;

                return Players[Turn].Inteligence.Level == AICategory.Human;
            }
        }

        public Game()
        {
            Players = new List<User>();
            _seed = new Random();
            Logger = new Logger();
        }

        public User AddPlayer(string name, AICategory level)
        {
            try
            {
                if (Players.Count >= MAX_PLAYERS)
                    return null;

                User u = new User(name, level);
                u.SetSecret(GetRandomSolution(u));
                u.Board.Logger = Logger;
                Players.Add(u);
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected Character GetRandomSolution(User u, int loop = 0)
        {
            int i = Enum.GetNames(typeof(Names)).Length;

            Character c = u.Board.Characters[_seed.Next(u.Board.Characters.Count)];
            foreach (User p in Players)
            {
                if (p.Name != u.Name && c.Name == p.Secret.Name)
                {
                    if (loop < 100)
                        return GetRandomSolution(u, ++loop);
                    else
                        throw new Exception("No characteres enough for this amount of users.");
                }
            }
            return c;
        }

        
        /// <summary>
        /// Indicates if the game can start or not.
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            if (!GameReady)
                return false;

            _turn = 0;
            return true;
        }


        public virtual bool Play_Step()
        {
            if(Winner != null)
            {
                Logger.WriteToLog(String.Format("{0} has won in {1} moves!", Winner, (_turn + 1)));
                return true;
            }

            bool endgame = false;
            User current, rival;

            current = Players[Turn];
            rival = GetRivalByPlayer(current);
            PrintGame(true);

            // Choose selected
            if (current.Inteligence.ShouldDoIAnswer(rival))
            {
                current.Choosen = current.Inteligence.GetChoosen();
                Logger.WriteToLog(String.Format("{0} is resolving: {1}.", current, current.Choosen));

                if (current.Choosen.Name == rival.Secret.Name)
                    endgame = true;
            }
            else
            {
                // Make Question
                Question question = current.Inteligence.ChooseQuestion();
                if (question == Question.None)
                    goto endmove;

                Logger.WriteToLog(String.Format("{0} is asking {1}.", current, GetFriendlyNameQuestion(question)));
                MakeQuestion(current, question);

            }


        endmove:
            if (!endgame)
            {
                ClearPlayerMove(current);
                NextMove();
            }
            return false;
        }


        public void PrintGame(bool showSecret = false)
        {
            string text = "";
            foreach (var p in Players)
            {
                text += "+---------------------------------------------------------------------------------------+" + Environment.NewLine;
                text += String.Format("| {0}", p.Name);
                if (showSecret)
                {
                    text += String.Format(" - [{0}: {1}]", p.Secret, p.Secret.GetAttributes());
                }
                text += Environment.NewLine;
                text += String.Format("| QA: {0}", p.Questions.Count) + Environment.NewLine;
                //foreach (var q in p.Questions)
                //{
                //    //text += GetFriendlyNameQuestion(q) + ", ";
                //    text += "| \t" + GetFriendlyNameQuestion(q) + Environment.NewLine;
                //}

                text += String.Format("| Board: {0}", p.Remainders) + Environment.NewLine;
                
                text += p.Board.ToString();

                text += Environment.NewLine;
            }
            Logger.WriteToLog(text);
        }

        public void NextMove()
        {
            _turn++;
        }

        public void ClearPlayerMove(User player)
        {
            player.Choosen = null;
        }


        public List<Character> MakeQuestion(User player, Question q)
        {
            if (!player.Questions.Contains(q))
                return null;

            User rival = GetRivalByPlayer(player);

            bool answer = rival.Answer(q);
            var result = player.MakeMove(q, answer);
            player.Questions.Remove(q);
            return result;
        }


        public User GetRivalByPlayer(User player)
        {
            foreach (var p in Players)
                if (p != player)
                    return p;
            return null;
        }

        public static string GetFriendlyNameQuestion(Question value)
        {
            try
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());
                var attribute = (DescriptionAttribute)fi.GetCustomAttribute(typeof(DescriptionAttribute));
                return attribute.Description;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static Question GetQuestionByFriendlyName(string question)
        {
            foreach(Question q in (Question[]) Enum.GetValues(typeof(Question)))
            {
                if (question == GetFriendlyNameQuestion(q))
                    return q;
            }
            return Question.None;
        }
    }
}
