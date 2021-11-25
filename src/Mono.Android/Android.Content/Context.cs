using System;
using Android.Runtime;

namespace Android.Content {

	public abstract partial class Context {

		public void StartActivity (Type type)
		{
			Intent intent = new Intent (this, type);
			StartActivity (intent);
		}

		public void GetSystemService<T> (string name) where T : Java.Lang.Object
		{
			return (T) GetSystemService (name);
		}
	}
}
