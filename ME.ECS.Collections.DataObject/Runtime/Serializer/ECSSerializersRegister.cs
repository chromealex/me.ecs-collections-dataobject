namespace ME.ECS.Serializer {

    public static class ECSSerializersRegister {

        static ECSSerializersRegister() {

            ECSSerializers.RegisterSerializer((ref Serializers ser) => {
                
                ser.Add(new DisposeSentinelSerializer());
                
            });

        }

    }

}