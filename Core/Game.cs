using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Game
    {
        private Random _seed;
        public static int MAX_PLAYERS = 2;

        public List<User> Players { get; set; }
        private int _turn;
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
                foreach(User u in Players)
                {
                    foreach(User r in Players)
                    {
                        if (u.Name != r.Name && u.Choosen == r.Secret)
                            return u;
                    }
                }
                return null;
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
                Players.Add(u);
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Character GetRandomSolution(User u, int loop = 0)
        {
            int i = Enum.GetNames(typeof(Names)).Length;

            Character c = u.Board.Characters[_seed.Next(u.Board.Characters.Count)];
            foreach(User p in Players)
            {
                if(p.Name != u.Name && c == p.Secret)
                {
                    if (loop < 100)
                        return GetRandomSolution(u, ++loop);
                    else
                        throw new Exception("No characteres enough for this amount of users.");
                }
            }
            return c;
        }

        public bool Play()
        {
            if (!GameReady)
                return false;

            _turn = 0;
            bool endgame = false;
            User current, rival;

            do
            {
                current = Players[Turn];
                rival = GetRivalByPlayer(current);
                PrintGame(true);
                // Make Question
                Question? question = current.Inteligence.ChooseQuestion();
                if(question == null)
                    goto endmove;

                Logger.WriteToLog(String.Format("{0} is asking {1}.", current, question.ToString()));
                MakeQuestion(current, question ?? default(Question));

                // Choose selected
                if(current.Inteligence.ShouldDoIAnswer(rival))
                {
                    current.Choosen = current.Inteligence.GetChoosen();
                    if (current.Choosen == rival.Secret)
                        endgame = true;
                }


            endmove:
                if (!endgame)
                {
                    ClearPlayerMove(current);
                    NextMove();

                    Console.ReadKey();
                }

            } while (!endgame);
            Logger.WriteToLog(String.Format("{0} has won in {1} moves!",Winner, (_turn+1)));
            Console.ReadKey();
            return true;
        }

        public void PrintGame(bool showSecret = false)
        {
            string text = "+----------------------------------------------+" + Environment.NewLine;
            foreach(var p in Players)
            {
                text += String.Format("| {0}",p.Name) + Environment.NewLine;
                text += String.Format("| QA: {0}",p.Questions.Count) + Environment.NewLine;
                text += "| \t ";
                foreach(var q in p.Questions)
                {
                    text += q + ", ";
                }
                text += Environment.NewLine;
                text += String.Format("| Board: {0}", p.Remainders) + Environment.NewLine;
                text += "| \t ";
                foreach (var c in p.Board.Characters)
                {
                    if(!c.Discarded)
                        text += c + ", ";
                }
                text += Environment.NewLine;
                if (showSecret)
                {
                    text += String.Format("| Secret {0}", p.Secret) + Environment.NewLine;
                }
                text += "+----------------------------------------------+" + Environment.NewLine;
            }
            Logger.WriteToLog(text);
        }

        private void NextMove()
        {
            _turn++;
        }

        public void ClearPlayerMove(User player)
        {
            player.Choosen = null;
        }


        public bool MakeQuestion(User player, Question q)
        {
            if (!player.Questions.Contains(q))
                return false;

            User rival = GetRivalByPlayer(player);
            
            bool answer = rival.Answer(q);
            bool result = player.MakeMove(q, answer);
            player.Questions.Remove(q);
            return result;
        }


        private User GetRivalByPlayer(User player)
        {
            foreach (var p in Players)
                if (p != player)
                    return p;
            return null;
        }
    }
}
