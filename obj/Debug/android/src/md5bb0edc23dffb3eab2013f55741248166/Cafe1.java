package md5bb0edc23dffb3eab2013f55741248166;


public class Cafe1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("FoodBooking.Cafe1, FoodBooking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Cafe1.class, __md_methods);
	}


	public Cafe1 ()
	{
		super ();
		if (getClass () == Cafe1.class)
			mono.android.TypeManager.Activate ("FoodBooking.Cafe1, FoodBooking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
