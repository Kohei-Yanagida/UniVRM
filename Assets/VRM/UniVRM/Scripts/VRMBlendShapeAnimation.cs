using System.Collections.Generic;
using UnityEngine;
using VRM;

[ExecuteAlways]
public class VRMBlendShapeAnimation : MonoBehaviour
{
    private VRMBlendShapeProxy _vrmBlendShapeProxy;

    [SerializeField] private List<float> BlendShapeClips;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_A = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_I = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_U = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_E = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_O = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_BLINK = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_JOY = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_ANGRY = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_SORROW = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_FUN = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKUP = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKDOWN = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKLEFT = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKRIGHT = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKBLINK_L = 0.0f;

    [SerializeField] [Range(0.0f, 1.0f)] private float _value_LOOKBLINK_R = 0.0f;

    private BlendShapeKey key_A;
    private BlendShapeKey key_I;
    private BlendShapeKey key_U;
    private BlendShapeKey key_E;
    private BlendShapeKey key_O;

    private List<KeyValuePair<BlendShapeKey, float>> blendShapeList = new List<KeyValuePair<BlendShapeKey, float>>();

    // Start is called before the first frame update
    void OnEnable()
    {
      
        if (!Application.isPlaying)
        {
            if (_vrmBlendShapeProxy == null)
            {
                _vrmBlendShapeProxy = GetComponent<VRMBlendShapeProxy>();
            }

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

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_A, _value_A));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_I, _value_I));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_U, _value_U));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_E, _value_E));
            blendShapeList.Add(new KeyValuePair<BlendShapeKey, float>(key_O, _value_O));

            _vrmBlendShapeProxy.SetValues(blendShapeList);
            _vrmBlendShapeProxy.Apply();

            blendShapeList.Clear();
        }
    }
}