using System.Collections.Generic;
using UnityEngine;
using VRM;

[ExecuteAlways]
public class VRMBlendShapeAnimation : MonoBehaviour
{
    [SerializeField] private VRMBlendShapeProxy _vrmBlendShapeProxy;

    public static string Prefix
    {
        get { return "_blendShapeClip_Value_"; }
    }


    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_NEUTRAL = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_A = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_I = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_U = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_E = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_O = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_BLINK = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_JOY = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_ANGRY = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_SORROW = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_FUN = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_LOOKUP = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_LOOKDOWN = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_LOOKLEFT = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_LOOKRIGHT = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_BLINK_L = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _blendShapeClip_Value_BLINK_R = 0.0f;

    
    private BlendShapeKey key_Neutral;
    private BlendShapeKey key_A;
    private BlendShapeKey key_I;
    private BlendShapeKey key_U;
    private BlendShapeKey key_E;
    private BlendShapeKey key_O;
    private BlendShapeKey key_Blink;
    private BlendShapeKey key_joy;
    private BlendShapeKey key_Angry;
    private BlendShapeKey key_Sorrow;
    private BlendShapeKey key_Fun;
    private BlendShapeKey key_LookUp;
    private BlendShapeKey key_LookDown;
    private BlendShapeKey key_LookLeft;
    private BlendShapeKey key_LookRight;
    private BlendShapeKey key_Blink_L;
    private BlendShapeKey key_Blink_R;

    private List<KeyValuePair<BlendShapeKey, float>> blendShapeList = new List<KeyValuePair<BlendShapeKey, float>>();

    // Start is called before the first frame update
    void OnEnable()
    {
        //    if (!Application.isPlaying)
        {
            if (_vrmBlendShapeProxy == null)
            {
                _vrmBlendShapeProxy = GetComponentInParent<VRMBlendShapeProxy>();
                return;
            }

            if (_vrmBlendShapeProxy != null)
            {
                var clip_neutral = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Neutral);
                key_Neutral =BlendShapeKey.CreateFrom(clip_neutral);
                
                var clip_A = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.A);
                key_A = BlendShapeKey.CreateFrom(clip_A);

                var clip_I = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.I);
                key_I = BlendShapeKey.CreateFrom(clip_I);

                var clip_U = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.U);
                key_U = BlendShapeKey.CreateFrom(clip_U);

                var clip_E = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.E);
                key_E = BlendShapeKey.CreateFrom(clip_E);
                
                var clip_O = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.O);
                key_O = BlendShapeKey.CreateFrom(clip_O);

                var clip_Blink = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Blink);
                key_Blink = BlendShapeKey.CreateFrom(clip_Blink);
                
                var clip_Joy = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Joy);
                key_joy = BlendShapeKey.CreateFrom(clip_Joy);
                
                var clip_Angry = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Angry);
                key_Angry = BlendShapeKey.CreateFrom(clip_Angry);
                
                var clip_Sorrow = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Sorrow);
                key_Sorrow = BlendShapeKey.CreateFrom(clip_Sorrow);
                
                var clip_Fun = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Fun);
                key_Fun = BlendShapeKey.CreateFrom(clip_Fun);
                
                var clip_LookUp = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.LookUp);
                key_LookUp = BlendShapeKey.CreateFrom(clip_LookUp);
                
                var clip_LookDown = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.LookDown);
                key_LookDown = BlendShapeKey.CreateFrom(clip_LookDown);
                
                var clip_LookLeft = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.LookLeft);
                key_LookLeft = BlendShapeKey.CreateFrom(clip_LookLeft);
                
                var clip_LookRight = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.LookRight);
                key_LookRight = BlendShapeKey.CreateFrom(clip_LookRight);
                
                var clip_Blink_L = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Blink_L);
                key_Blink_L = BlendShapeKey.CreateFrom(clip_Blink_L);
                
                var clip_Blink_R = _vrmBlendShapeProxy.BlendShapeAvatar.GetClip(BlendShapePreset.Blink_R);
                key_Blink_R = BlendShapeKey.CreateFrom(clip_Blink_R);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_vrmBlendShapeProxy != null)
        {
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Neutral, _blendShapeClip_Value_NEUTRAL));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_A, _blendShapeClip_Value_A));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_I, _blendShapeClip_Value_I));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_U, _blendShapeClip_Value_U));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_E, _blendShapeClip_Value_E));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_O, _blendShapeClip_Value_O));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Blink, _blendShapeClip_Value_BLINK));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_joy, _blendShapeClip_Value_JOY));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Angry, _blendShapeClip_Value_ANGRY));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Sorrow, _blendShapeClip_Value_SORROW));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Fun, _blendShapeClip_Value_FUN));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_LookUp, _blendShapeClip_Value_LOOKUP));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_LookDown, _blendShapeClip_Value_LOOKDOWN));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_LookLeft, _blendShapeClip_Value_LOOKLEFT));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_LookRight, _blendShapeClip_Value_LOOKRIGHT));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Blink_L, _blendShapeClip_Value_BLINK_L));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_Blink_R, _blendShapeClip_Value_BLINK_R));

            _vrmBlendShapeProxy.SetValues(blendShapeList);
            _vrmBlendShapeProxy.Apply();

            blendShapeList.Clear();
        }
    }
}