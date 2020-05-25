using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Posandroid.Receiptgenerator.Model
{
	public abstract partial class PrintTypeReceipt
	{
		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ActivationClientPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$ActivationClientPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class ActivationClientPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$ActivationClientPrintReceipt", typeof(ActivationClientPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal ActivationClientPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ActivationClientPrintReceipt']/constructor[@name='PrintTypeReceipt.ActivationClientPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.activation.client.ActivationClientReceipt']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/activation/client/ActivationClientReceipt;)V", "")]
			public unsafe ActivationClientPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Activation.Client.ActivationClientReceipt activationClientReceipt)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/activation/client/ActivationClientReceipt;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((activationClientReceipt == null) ? IntPtr.Zero : ((global::Java.Lang.Object)activationClientReceipt).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Activation.Client.ActivationClientReceipt ActivationClientReceipt
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ActivationClientPrintReceipt']/method[@name='getActivationClientReceipt' and count(parameter)=0]"
				[Register("getActivationClientReceipt", "()Lbr/com/posandroid/receiptgenerator/model/activation/client/ActivationClientReceipt;", "")]
				get
				{
					const string __id = "getActivationClientReceipt.()Lbr/com/posandroid/receiptgenerator/model/activation/client/ActivationClientReceipt;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Activation.Client.ActivationClientReceipt>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelClientPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$CancelClientPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class CancelClientPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$CancelClientPrintReceipt", typeof(CancelClientPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal CancelClientPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelClientPrintReceipt']/constructor[@name='PrintTypeReceipt.CancelClientPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.cancel.client.CancelClientReceipt']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/cancel/client/CancelClientReceipt;)V", "")]
			public unsafe CancelClientPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Client.CancelClientReceipt cancelClientReceipt)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/cancel/client/CancelClientReceipt;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((cancelClientReceipt == null) ? IntPtr.Zero : ((global::Java.Lang.Object)cancelClientReceipt).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Client.CancelClientReceipt CancelClientReceipt
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelClientPrintReceipt']/method[@name='getCancelClientReceipt' and count(parameter)=0]"
				[Register("getCancelClientReceipt", "()Lbr/com/posandroid/receiptgenerator/model/cancel/client/CancelClientReceipt;", "")]
				get
				{
					const string __id = "getCancelClientReceipt.()Lbr/com/posandroid/receiptgenerator/model/cancel/client/CancelClientReceipt;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Client.CancelClientReceipt>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelEstablishmentPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$CancelEstablishmentPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class CancelEstablishmentPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$CancelEstablishmentPrintReceipt", typeof(CancelEstablishmentPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal CancelEstablishmentPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelEstablishmentPrintReceipt']/constructor[@name='PrintTypeReceipt.CancelEstablishmentPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.cancel.establishment.CancelEstablishmentReceipt']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/cancel/establishment/CancelEstablishmentReceipt;)V", "")]
			public unsafe CancelEstablishmentPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Establishment.CancelEstablishmentReceipt cancelEstablishmentReceipt)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/cancel/establishment/CancelEstablishmentReceipt;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((cancelEstablishmentReceipt == null) ? IntPtr.Zero : ((global::Java.Lang.Object)cancelEstablishmentReceipt).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Establishment.CancelEstablishmentReceipt CancelEstablishmentReceipt
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.CancelEstablishmentPrintReceipt']/method[@name='getCancelEstablishmentReceipt' and count(parameter)=0]"
				[Register("getCancelEstablishmentReceipt", "()Lbr/com/posandroid/receiptgenerator/model/cancel/establishment/CancelEstablishmentReceipt;", "")]
				get
				{
					const string __id = "getCancelEstablishmentReceipt.()Lbr/com/posandroid/receiptgenerator/model/cancel/establishment/CancelEstablishmentReceipt;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Cancel.Establishment.CancelEstablishmentReceipt>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentClientPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$PaymentClientPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class PaymentClientPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$PaymentClientPrintReceipt", typeof(PaymentClientPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal PaymentClientPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentClientPrintReceipt']/constructor[@name='PrintTypeReceipt.PaymentClientPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.payment.client.PaymentClientReceipt']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/payment/client/PaymentClientReceipt;)V", "")]
			public unsafe PaymentClientPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Client.PaymentClientReceipt paymentClientReceipt)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/payment/client/PaymentClientReceipt;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((paymentClientReceipt == null) ? IntPtr.Zero : ((global::Java.Lang.Object)paymentClientReceipt).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Client.PaymentClientReceipt PaymentClientReceipt
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentClientPrintReceipt']/method[@name='getPaymentClientReceipt' and count(parameter)=0]"
				[Register("getPaymentClientReceipt", "()Lbr/com/posandroid/receiptgenerator/model/payment/client/PaymentClientReceipt;", "")]
				get
				{
					const string __id = "getPaymentClientReceipt.()Lbr/com/posandroid/receiptgenerator/model/payment/client/PaymentClientReceipt;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Client.PaymentClientReceipt>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentEstablishmentPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$PaymentEstablishmentPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class PaymentEstablishmentPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$PaymentEstablishmentPrintReceipt", typeof(PaymentEstablishmentPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal PaymentEstablishmentPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentEstablishmentPrintReceipt']/constructor[@name='PrintTypeReceipt.PaymentEstablishmentPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.payment.establishment.PaymentEstablishmentReceipt']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/payment/establishment/PaymentEstablishmentReceipt;)V", "")]
			public unsafe PaymentEstablishmentPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Establishment.PaymentEstablishmentReceipt paymentEstablishmentReceipt)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/payment/establishment/PaymentEstablishmentReceipt;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((paymentEstablishmentReceipt == null) ? IntPtr.Zero : ((global::Java.Lang.Object)paymentEstablishmentReceipt).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Establishment.PaymentEstablishmentReceipt PaymentEstablishmentReceipt
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.PaymentEstablishmentPrintReceipt']/method[@name='getPaymentEstablishmentReceipt' and count(parameter)=0]"
				[Register("getPaymentEstablishmentReceipt", "()Lbr/com/posandroid/receiptgenerator/model/payment/establishment/PaymentEstablishmentReceipt;", "")]
				get
				{
					const string __id = "getPaymentEstablishmentReceipt.()Lbr/com/posandroid/receiptgenerator/model/payment/establishment/PaymentEstablishmentReceipt;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Payment.Establishment.PaymentEstablishmentReceipt>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ReportPrintReceipt']"
		[global::Android.Runtime.Register("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$ReportPrintReceipt", DoNotGenerateAcw = true)]
		public sealed partial class ReportPrintReceipt : global::BR.Com.Posandroid.Receiptgenerator.Model.PrintTypeReceipt
		{
			private new static readonly JniPeerMembers _members = new XAPeerMembers("br/com/posandroid/receiptgenerator/model/PrintTypeReceipt$ReportPrintReceipt", typeof(ReportPrintReceipt));

			internal static new IntPtr class_ref
			{
				get
				{
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers
			{
				get { return _members; }
			}

			protected override IntPtr ThresholdClass
			{
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return _members.ManagedPeerType; }
			}

			internal ReportPrintReceipt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ReportPrintReceipt']/constructor[@name='PrintTypeReceipt.ReportPrintReceipt' and count(parameter)=1 and parameter[1][@type='br.com.posandroid.receiptgenerator.model.report.Report']]"
			[Register(".ctor", "(Lbr/com/posandroid/receiptgenerator/model/report/Report;)V", "")]
			public unsafe ReportPrintReceipt(global::BR.Com.Posandroid.Receiptgenerator.Model.Report.Report report)
				: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lbr/com/posandroid/receiptgenerator/model/report/Report;)V";

				if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
					return;

				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue((report == null) ? IntPtr.Zero : ((global::Java.Lang.Object)report).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
					SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
				}
				finally
				{
				}
			}

			public unsafe global::BR.Com.Posandroid.Receiptgenerator.Model.Report.Report Report
			{
				// Metadata.xml XPath method reference: path="/api/package[@name='br.com.posandroid.receiptgenerator.model']/class[@name='PrintTypeReceipt.ReportPrintReceipt']/method[@name='getReport' and count(parameter)=0]"
				[Register("getReport", "()Lbr/com/posandroid/receiptgenerator/model/report/Report;", "")]
				get
				{
					const string __id = "getReport.()Lbr/com/posandroid/receiptgenerator/model/report/Report;";
					try
					{
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
						return global::Java.Lang.Object.GetObject<global::BR.Com.Posandroid.Receiptgenerator.Model.Report.Report>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
					}
				}
			}

		}
	}
	
}
