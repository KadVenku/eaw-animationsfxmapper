using Caliburn.Micro;
using pg.animationsfxmap.data.impl;

namespace eaw_animationsfxmapper.ViewModels
{
    public class SoundEventCardViewModel : PropertyChangedBase
    {
        private readonly SoundEvent _event;
        public string SoundEventName;
        public string AnimationName;
        public int FrameStart;
    }
}
