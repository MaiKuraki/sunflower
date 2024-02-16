#if VIRTUESKY_SKELETON
using Spine.Unity;
using UnityEngine;

namespace VirtueSky.Component
{
    [RequireComponent(typeof(SkeletonAnimation))]
    public class SkinSkeletonComponent : SkinSkeleton
    {
        [SerializeField] private SkeletonAnimation skeletonAnimation;
        public SkeletonAnimation SkeletonAnimation => skeletonAnimation;

        public override void Init()
        {
            skeleton = skeletonAnimation.Skeleton;
            animationState = skeletonAnimation.AnimationState;
        }
#if UNITY_EDITOR
        private void Reset()
        {
            if (skeletonAnimation == null)
            {
                skeletonAnimation = GetComponent<SkeletonAnimation>();
            }
        }
#endif
    }
}

#endif