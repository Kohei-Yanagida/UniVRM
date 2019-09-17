using System;
using UniJSON;

namespace UniGLTF
{
    [Serializable]
    public class VRM_BlendShapeClip_Animation : JsonSerializableBase
    {
        public static string ExtensionName
        {
            get { return "VRM_BlendShapeClip_Animation"; }
        }

        protected override void SerializeMembers(GLTFJsonFormatter f)
        {
            //throw new System.NotImplementedException();
        }
    }

    [Serializable]
    public partial class glTFAnimation_extensions : ExtensionsBase<glTFAnimation_extensions>
    {
        [JsonSchema(Required = true)] 
        public VRM_BlendShapeClip_Animation VRM_BlendShapeClip_Animation;

        [JsonSerializeMembers]
        void SerializeMembers(GLTFJsonFormatter f)
        {
       //     if (VRM_BlendShapeClip_Animation != null)
            {
                f.Key("VRM_BlendShapeClip_Animation");
                f.GLTFValue(VRM_BlendShapeClip_Animation);
            }
        }
    }
}