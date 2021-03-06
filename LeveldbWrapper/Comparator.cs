﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Comparator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Comparator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Comparator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Comparator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Comparator(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Comparator __CreateInstance(global::Leveldb.Comparator.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Comparator(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Comparator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Comparator.__Internal));
            *(global::Leveldb.Comparator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Comparator(global::Leveldb.Comparator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Comparator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
