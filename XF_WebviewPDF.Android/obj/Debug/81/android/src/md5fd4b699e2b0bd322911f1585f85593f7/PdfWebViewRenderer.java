package md5fd4b699e2b0bd322911f1585f85593f7;


public class PdfWebViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.WebViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onKeyDown:(ILandroid/view/KeyEvent;)Z:GetOnKeyDown_ILandroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("XF_WebviewPDF.Droid.CustomRenderers.PdfWebViewRenderer, XF_WebviewPDF.Android", PdfWebViewRenderer.class, __md_methods);
	}


	public PdfWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PdfWebViewRenderer.class)
			mono.android.TypeManager.Activate ("XF_WebviewPDF.Droid.CustomRenderers.PdfWebViewRenderer, XF_WebviewPDF.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public PdfWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PdfWebViewRenderer.class)
			mono.android.TypeManager.Activate ("XF_WebviewPDF.Droid.CustomRenderers.PdfWebViewRenderer, XF_WebviewPDF.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public PdfWebViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PdfWebViewRenderer.class)
			mono.android.TypeManager.Activate ("XF_WebviewPDF.Droid.CustomRenderers.PdfWebViewRenderer, XF_WebviewPDF.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean onKeyDown (int p0, android.view.KeyEvent p1)
	{
		return n_onKeyDown (p0, p1);
	}

	private native boolean n_onKeyDown (int p0, android.view.KeyEvent p1);

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
