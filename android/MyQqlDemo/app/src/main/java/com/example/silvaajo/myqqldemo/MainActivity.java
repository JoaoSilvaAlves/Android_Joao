package com.example.silvaajo.myqqldemo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    EditText UsernameET, PasswordEt;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        UsernameET = (EditText)findViewById(R.id.etUserName);
        PasswordEt = (EditText)findViewById(R.id.etPassword);
    }


    public void OnLogin(View view){
        String username = UsernameET.getText().toString();
        String password = PasswordEt.getText().toString();
        String type = "login";
        BackgroundWalker backgroundWalker = new BackgroundWalker(this);
        backgroundWalker.execute(type, username, password);
    }

}
