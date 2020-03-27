using Android.Runtime;
using Java.Interop;
using System;

namespace Stone.Environment.Factory
{
	public sealed partial class AuthorizeFactory
	{
		[Register("getEnvironment", "(Lstone/environment/Environment;)Lstone/environment/interfaces/AuthorizerEnvironment;", "GetGetEnvironment_Lstone_environment_Environment_Handler")]
		public override unsafe Interfaces.IEnvironmentServices GetEnvironment(Environment environment)
		{
			const string __id = "getEnvironment.(Lstone/environment/Environment;)Lstone/environment/interfaces/AuthorizerEnvironment;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((environment == null) ? IntPtr.Zero : environment.Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return GetObject<Interfaces.AuthorizerEnvironment>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
}