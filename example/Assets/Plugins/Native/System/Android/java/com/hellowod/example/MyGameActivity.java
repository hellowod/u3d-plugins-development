package com.hellowod.example;

import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayerActivity;

public class MyGameActivity extends UnityPlayerActivity {
	private static String TAG = "MyGameActivity";

    @Override
    protected void onCreate(Bundle var1) {
        super.onCreate(var1);
        Log.d(TAG, "onCreate called!");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.d(TAG, "onResume called!");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.d(TAG, "onDestroy called!");
    }
}