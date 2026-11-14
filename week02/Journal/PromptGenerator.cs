
using System;
using System.Collections.Generic;

namespace JournalApp
{

    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();
        public PromptGenerator()
        {
            _prompts.Add("What career am i most likely to choose? ");
            _prompts.Add("What food am i most likely to eat? ");
            _prompts.Add("What did i do for exercise today? ");
            _prompts.Add("Who did i talk to on my way back home? ");
            _prompts.Add("What am i thinking about right now? ");   
        }
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return  _prompts[index];
        }
    }   
}