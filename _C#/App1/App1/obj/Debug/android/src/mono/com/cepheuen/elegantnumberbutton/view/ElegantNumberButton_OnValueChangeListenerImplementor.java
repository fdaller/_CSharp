package mono.com.cepheuen.elegantnumberbutton.view;


public class ElegantNumberButton_OnValueChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.cepheuen.elegantnumberbutton.view.ElegantNumberButton.OnValueChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChange:(Lcom/cepheuen/elegantnumberbutton/view/ElegantNumberButton;II)V:GetOnValueChange_Lcom_cepheuen_elegantnumberbutton_view_ElegantNumberButton_IIHandler:Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton/IOnValueChangeListenerInvoker, ElegantNumberButton\n" +
			"";
		mono.android.Runtime.register ("Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton+IOnValueChangeListenerImplementor, ElegantNumberButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ElegantNumberButton_OnValueChangeListenerImplementor.class, __md_methods);
	}


	public ElegantNumberButton_OnValueChangeListenerImplementor ()
	{
		super ();
		if (getClass () == ElegantNumberButton_OnValueChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton+IOnValueChangeListenerImplementor, ElegantNumberButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onValueChange (com.cepheuen.elegantnumberbutton.view.ElegantNumberButton p0, int p1, int p2)
	{
		n_onValueChange (p0, p1, p2);
	}

	private native void n_onValueChange (com.cepheuen.elegantnumberbutton.view.ElegantNumberButton p0, int p1, int p2);

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
