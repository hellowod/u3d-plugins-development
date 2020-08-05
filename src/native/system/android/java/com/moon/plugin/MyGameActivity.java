package com.moon.plugin;

import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayerActivity;

public class MyGameActivity extends UnityPlayerActivity {

    @Override
    protected void onCreate(Bundle var1) {
        super.onCreate(var1);
        Log.d(AppConst.TAG, "onCreate called!");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.d(AppConst.TAG, "onResume called!");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.d(AppConst.TAG, "onDestroy called!");
    }
}