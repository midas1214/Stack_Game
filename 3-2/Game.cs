using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Game
    {
        //game instance
        private static Stack<int> stack1 = new Stack<int>();
        private static Stack<int> stack2 = new Stack<int>();
        private static Stack<int> stack3 = new Stack<int>();
        private static Stack<int> stack4 = new Stack<int>();
        private Stack<int>[] stacks = new Stack<int>[4] { stack1, stack2, stack3, stack4 };
        //public method
        public bool canplace(int i)
        {
            if (stacks[i].Count >= 4)
            {
                return false;
            }
            return true;
        }
        public bool cantake(int i)
        {
            if (stacks[i].Count <= 0)
            {
                return false;
            }
            return true;
        }
        public void move(int i, int j)
        {
            stacks[j].Push(stacks[i].Pop());
        }
        public string output(int i)
        {
            string s = "";
            foreach (int j in stacks[i])
            {
                s += j;
                s += "\n";
            }
            return s;
        }
        public bool win()
        {
            int finish = 0;
            for (int i = 0; i < 4; i++)
            {
                if (stacks[i].All(s => s == stacks[i].Peek()) && stacks[i].Count == 3)
                {
                    finish++;
                }
            }
            if (finish == 3)
            {
                return true;
            }
            return false;
        }
        public Game(string[] input)
        {
            stack1.Clear();
            stack2.Clear();
            stack3.Clear();
            stack4.Clear();
            for (int i = 0; i < 4; i++)
            {
                string[] splits = input[i].Split(' ');
                foreach (var split in splits)
                {
                    if (split == "1")
                    {
                        stacks[i].Push(1);
                    }
                    else if (split == "2")
                    {
                        stacks[i].Push(2);
                    }
                    else if (split == "3")
                    {
                        stacks[i].Push(3);
                    }
                }
            }
        }
    }
}
