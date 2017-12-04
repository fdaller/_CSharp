package mono.com.cepheuen.elegantnumberbutton.view;


public class ElegantNumberButton_OnClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.cepheuen.elegantnumberbutton.view.ElegantNumberButton.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton/IOnClickListenerInvoker, ElegantNumberButton\n" +
			"";
		mono.android.Runtime.register ("Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton+IOnClickListenerImplementor, ElegantNumberButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ElegantNumberButton_OnClickListenerImplementor.class, __md_methods);
	}


	public ElegantNumberButton_OnClickListenerImplementor ()
	{
		super ();
		if (getClass () == ElegantNumberButton_OnClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton+IOnClickListenerImplementor, ElegantNumberButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
