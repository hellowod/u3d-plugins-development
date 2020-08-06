package com.hellowod.example;

import android.app.Application;
import android.util.Log;

public class MyGameApplication extends Application {
	private static String TAG = "MyGameActivity";

    @Override
    public void onCreate() {
        super.onCreate();
        Log.d(TAG, "MyGameApplication.onCreate");
    }
}