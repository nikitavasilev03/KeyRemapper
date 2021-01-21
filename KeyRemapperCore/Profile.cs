using System;
using System.Collections.Generic;
using HookCore.Models;
using KeyRemapperCore.Exceptions;

namespace KeyRemapperCore
{
    [Serializable]
    public class Profile
    {
        public string Name { get; set; }
        public List<KeysRule> RulesMap { get; } = new List<KeysRule>();
        
        public Profile(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ProfileCreateException("Не допустимое имя профиля");
            Name = name;
        }

        public bool AddRule(KeysRule keysRule)
        {
            if (RulesMap.Contains(keysRule))
                return false;
            RulesMap.Add(keysRule);
            return true;
        }

        public KeysRule AddRule(Key press, Key send)
        {
            KeysRule keysRule = new KeysRule(press, send);
            if (AddRule(keysRule))
                return keysRule;
            return null;
        }

        public bool RemoveRule(KeysRule keysRule)
        {
            if (!RulesMap.Contains(keysRule))
                return false;
            RulesMap.Remove(keysRule);
            return true;
        }

        public bool RemoveRule(Key press, Key send)
        {
            KeysRule keysRule = new KeysRule(press, send);
            return RemoveRule(keysRule);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
