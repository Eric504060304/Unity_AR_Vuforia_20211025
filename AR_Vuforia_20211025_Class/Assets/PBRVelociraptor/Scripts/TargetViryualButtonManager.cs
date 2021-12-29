using UnityEngine;
using Vuforia;

namespace Eric
{
    /// <summary>
    /// �ϥd�ؼЪ��������s�޲z��
    /// </summary>
    public class TargetViryualButtonManager : MonoBehaviour
    {
        [Header("�n��ť���������s")]
        public VirtualButtonBehaviour vbbBite;
        [Header("�n����ʵe����")]
        public Animator aniTarget;

        private void Start()
        {
            //�������s ���U���U��n���檺��k
            vbbBite.RegisterOnButtonPressed(PlayBiteAnimation);
        }
        /// <summary>
        /// ����ʵe����k�A�������s���U�n���檺��k
        /// </summary>
        /// <param name="vbb">�������s���U�Ϊ��Ѽ�</param>
        void PlayBiteAnimation(VirtualButtonBehaviour vbb)
        {
            if (vbb.VirtualButtonName == "���r�s�r")
            {
                aniTarget.SetTrigger("Ĳ�o�r");
            }
        }
    }
}

