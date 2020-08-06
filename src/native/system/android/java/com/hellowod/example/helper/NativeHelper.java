package com.hellowod.example.helper;

import android.app.Service;
import android.content.Context;
import android.content.ContextWrapper;
import android.content.Intent;
import android.content.IntentFilter;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.os.BatteryManager;
import android.os.Build;
import android.os.Vibrator;

import com.hellowod.example.MyGameApplication;

import static android.content.Context.BATTERY_SERVICE;

public class NativeHelper {
    public static int add(int a, int b){
		return a + b;
	}
	
	public static int sub(int a, int b){
		return a - b;
	}
	
	public static int div(int a, int b){
		return a / b;
	}
	
	public static int mul(int a, int b){
		return a * b;
	}

	/**
	 * 震屏
	 * @param time 时长
	 */
	public static void shockScreen(int time) {
		Context context = MyGameApplication.getContext();
		if (context != null) {
			Vibrator vib = (Vibrator) context.getSystemService(Service.VIBRATOR_SERVICE);
			vib.vibrate(time);
		}
	}

	/**
	 * 是否震屏
	 * @return
	 */
	public static boolean hasShockScreen() {
		Context context = MyGameApplication.getContext();
		if (context != null) {
			Vibrator vib = (Vibrator) context.getSystemService(Service.VIBRATOR_SERVICE);
			return vib.hasVibrator();
		}
		return false;
	}

	/**
	 * 取消震屏
	 */
	public static void cancelShockScreen(){
		Context context = MyGameApplication.getContext();
		if (context != null) {
			Vibrator vib = (Vibrator) context.getSystemService(Service.VIBRATOR_SERVICE);
			vib.cancel();
		}
	}

	/**
	 * 获取当前手机电量
	 * @return
	 */
	public static int getBattery(){
		Context context = MyGameApplication.getContext();
		if (context == null) {
			return 0;
		}
		if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
			BatteryManager batteryManager = (BatteryManager) context.getSystemService(BATTERY_SERVICE);
			return batteryManager.getIntProperty(BatteryManager.BATTERY_PROPERTY_CAPACITY);
		} else {
			Intent intent = new ContextWrapper(context).
					registerReceiver(null, new IntentFilter(Intent.ACTION_BATTERY_CHANGED));
			return (intent.getIntExtra(BatteryManager.EXTRA_LEVEL, -1) * 100) /
					intent.getIntExtra(BatteryManager.EXTRA_SCALE, -1);
		}
	}

	/**
	 * 是否连接网络
	 * @return
	 */
	public static boolean isNetConnect(){
		Context context = MyGameApplication.getContext();
		if (context == null) {
			return false;
		}
		ConnectivityManager connectivity = (ConnectivityManager) context.getSystemService(Context.CONNECTIVITY_SERVICE);
		if (connectivity != null) {
			NetworkInfo info = connectivity.getActiveNetworkInfo();
			if (info != null && info.isConnected()) {
				if (info.getState() == NetworkInfo.State.CONNECTED) {
					return true;
				}
			}
		}
		return false;
	}

	/**
	 * 是否连接无线网络
	 * @return
	 */
	public static boolean isWifiConnected() {
		Context context = MyGameApplication.getContext();
		if (context == null) {
			return false;
		}
		ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService(Context.CONNECTIVITY_SERVICE);
		if (connectivityManager != null) {
			NetworkInfo networkInfo = connectivityManager.getActiveNetworkInfo();
			if (networkInfo != null) {
				int networkInfoType = networkInfo.getType();
				if (networkInfoType == ConnectivityManager.TYPE_WIFI || networkInfoType == ConnectivityManager.TYPE_ETHERNET) {
					return networkInfo.isConnected();
				}
			}
		}
		return false;
	}

	/**
	 * 获取无线信号强度（0-100）
	 * @return
	 */
	public static int getNetworkLevel(){
		Context context = MyGameApplication.getContext();
		if (context == null) {
			return 0;
		}
		int signalLevel = 0;
		ConnectivityManager connectivityManager = (ConnectivityManager)context.getSystemService(Context.CONNECTIVITY_SERVICE);
		NetworkInfo info = connectivityManager.getActiveNetworkInfo();
		if (info != null && info.isAvailable()) {
			switch (info.getType()) {
				case ConnectivityManager.TYPE_WIFI:
					WifiManager manager = (WifiManager) context.getApplicationContext().getSystemService(Context.WIFI_SERVICE);
					WifiInfo connectionInfo = manager.getConnectionInfo();
					signalLevel = connectionInfo.getRssi();
					break;
				case ConnectivityManager.TYPE_MOBILE://需要实现
					signalLevel = 2;
			}
		}
		return signalLevel;
	}
}
