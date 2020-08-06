package com.hellowod.example;

import android.app.Application;
import android.util.Log;

public class MyGameApplication extends Application {

    @Override
    public void onCreate() {
        super.onCreate();
        Log.d(AppConst.TAG, "MyGameApplication.onCreate");
    }
}