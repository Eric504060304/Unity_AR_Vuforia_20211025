using UnityEngine;
using Vuforia;

namespace Eric
{
    /// <summary>
    /// 圖卡目標的虛擬按鈕管理氣
    /// </summary>
    public class TargetViryualButtonManager : MonoBehaviour
    {
        [Header("要監聽的虛擬按鈕")]
        public VirtualButtonBehaviour vbbBite;
        [Header("要控制的動畫元件")]
        public Animator aniTarget;

        private void Start()
        {
            //虛擬按鈕 註冊按下後要執行的方法
            vbbBite.RegisterOnButtonPressed(PlayBiteAnimation);
        }
        /// <summary>
        /// 播放動畫的方法，虛擬按鈕按下要執行的方法
        /// </summary>
        /// <param name="vbb">虛擬按鈕註冊用的參數</param>
        void PlayBiteAnimation(VirtualButtonBehaviour vbb)
        {
            if (vbb.VirtualButtonName == "迅猛龍咬")
            {
                aniTarget.SetTrigger("觸發咬");
            }
        }
    }
}

