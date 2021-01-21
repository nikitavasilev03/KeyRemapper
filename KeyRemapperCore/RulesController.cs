using System;
using System.Linq;
using HookCore.Listeners;
using HookCore.Models;
using KeyHookCore.Interfaces;
using KeyRemapperCore.Interfaces;

namespace KeyRemapperCore
{
    public class RulesController
    {
        private readonly ILoader profilesLoader;
        private readonly IKeySender sender;
        private readonly IListenerHook listenerHook = new KeyboardKeyHookListener();
        public ProfilesManager Manager { get; }
        public Profile Profile => Manager.CurrentProfile;
        public bool IsListening => listenerHook.Hooked;
        private KeysRule currentRule;

        public RulesController(ILoader loader, IKeySender sender)
        {
            profilesLoader = loader;
            this.sender = sender;
            listenerHook.HandleHook = HandleHook;

            try
            {
                Manager = loader.Load();
                StartKeyListen();
            }
            catch (Exception)
            {
                Manager = null;
            }
            finally
            {
                if (Manager == null)
                {
                    Manager = new ProfilesManager();
                    var profile = Manager.AddProfile("Default");
                    Manager.CurrentProfile = profile;
                }
            }
        }

        public KeysRule AddRule(Key pressKey, Key sendKey)
        {
            return Profile.AddRule(pressKey, sendKey);
        }

        public bool RemoveRule(KeysRule rule)
        {
            return Profile.RemoveRule(rule);
        }

        public void StartKeyListen()
        {
            listenerHook?.Hook();
        }

        public void StopKeyListen()
        {
            listenerHook?.Unhook();
        }

        private HookResult HandleHook(Hook hook)
        {
            var kh = hook as KeyHook;
            if (kh == null)
                return HookResult.Release;
            
            Key key = kh.Key;
            if (currentRule == null)
            {
                currentRule = Profile.RulesMap.FirstOrDefault(r => r.KeyPress == key);
                if (currentRule != null) sender.Send(currentRule.KeySend);
                if (Profile.RulesMap.Any(r => r.KeyPress == key && r.KeySend == Key.None))
                    return HookResult.NoRelease;
            }
            else
                currentRule = null;

            return HookResult.Release;
        }

        public void SaveChange()
        {
            profilesLoader.Save(Manager);
        }
    }
}
