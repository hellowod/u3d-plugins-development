package com.hellowod.example;

import android.app.Application;
import android.content.Context;
import android.util.Log;

public class MyGameApplication extends Application {
	private static String TAG = "MyGameActivity";

	private static Context context;

    @Override
    public void onCreate() {
        super.onCreate();
        context = getApplicationContext();
        Log.d(TAG, "MyGameApplication.onCreate");
    }

    public static Context getContext(){
        return context;
    }
}