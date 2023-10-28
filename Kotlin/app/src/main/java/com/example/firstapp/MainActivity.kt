package com.example.firstapp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var text1:TextView= findViewById(R.id.MyText);
        var but2:Button = findViewById(R.id.MyButton);
        var img1:ImageView = findViewById(R.id.img1)
        but2.setOnClickListener{
            text1.setText("shruti");
            img1.setImageResource(androidx.constraintlayout.widget.R.drawable.abc_ic_arrow_drop_right_black_24dp);
        }
    }
}