// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: canbus_conf.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.canbus
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CanbusConf : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CanbusConf()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public VehicleParameter vehicle_parameter { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::apollo.drivers.canbus.CANCardParameter can_card_parameter { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_debug_mode
        {
            get { return __pbn__enable_debug_mode ?? false; }
            set { __pbn__enable_debug_mode = value; }
        }
        public bool ShouldSerializeenable_debug_mode()
        {
            return __pbn__enable_debug_mode != null;
        }
        public void Resetenable_debug_mode()
        {
            __pbn__enable_debug_mode = null;
        }
        private bool? __pbn__enable_debug_mode;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_receiver_log
        {
            get { return __pbn__enable_receiver_log ?? false; }
            set { __pbn__enable_receiver_log = value; }
        }
        public bool ShouldSerializeenable_receiver_log()
        {
            return __pbn__enable_receiver_log != null;
        }
        public void Resetenable_receiver_log()
        {
            __pbn__enable_receiver_log = null;
        }
        private bool? __pbn__enable_receiver_log;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_sender_log
        {
            get { return __pbn__enable_sender_log ?? false; }
            set { __pbn__enable_sender_log = value; }
        }
        public bool ShouldSerializeenable_sender_log()
        {
            return __pbn__enable_sender_log != null;
        }
        public void Resetenable_sender_log()
        {
            __pbn__enable_sender_log = null;
        }
        private bool? __pbn__enable_sender_log;

    }

}

#pragma warning restore 0612, 1591, 3021