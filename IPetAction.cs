namespace VirtualPetSimulator
{
    public interface IPetAction
    {
        string Label { get; }
        void Apply(VirtualPet pet);
    }

    public class FeedAction : IPetAction
    {
        public string Label => "Feed";
        public void Apply(VirtualPet pet) => pet.Eat("kibble");
    }

    public class NapAction : IPetAction
    {
        public string Label => "Nap";
        public void Apply(VirtualPet pet) => pet.Sleep();
    }

    public class PlayAction : IPetAction
    {
        public string Label => "Play";
        public void Apply(VirtualPet pet)
        {
            pet.Wake();
            // playing gives XP via “special food” trick to keep code short
            pet.Eat("a treat after playing");
        }
    }
}
