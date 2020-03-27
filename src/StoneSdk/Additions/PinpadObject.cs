using Android.Runtime;
using Java.Interop;
using System;

namespace Stone.Utils
{
	public partial class PinpadObject
	{
		[Register("compareTo", "(Lstone/utils/PinpadObject;)I", "GetCompareTo_Lstone_utils_PinpadObject_Handler")]
		public unsafe int CompareTo(Java.Lang.Object otherPinpad)
		{
			const string __id = "compareTo.(Lstone/utils/PinpadObject;)I";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((otherPinpad == null) ? IntPtr.Zero : otherPinpad.Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
				return __rm;
			}
			finally
			{
			}
		}
	}
}