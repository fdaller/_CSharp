package md5579855c995bdb073d8182511e793544c;


public class test_activity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.cepheuen.elegantnumberbutton.view.ElegantNumberButton.OnValueChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onValueChange:(Lcom/cepheuen/elegantnumberbutton/view/ElegantNumberButton;II)V:GetOnValueChange_Lcom_cepheuen_elegantnumberbutton_view_ElegantNumberButton_IIHandler:Com.Cepheuen.Elegantnumberbutton.View.ElegantNumberButton/IOnValueChangeListenerInvoker, ElegantNumberButton\n" +
			"";
		mono.android.Runtime.register ("App1.test_activity, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", test_activity.class, __md_methods);
	}


	public test_activity ()
	{
		super ();
		if (getClass () == test_activity.class)
			mono.android.TypeManager.Activate ("App1.test_activity, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


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
