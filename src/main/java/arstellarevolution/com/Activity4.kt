package arstellarevolution.com

import android.content.Intent
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.testar.project.UnityPlayerActivity

class Activity4 : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_4)

        val testButton = findViewById<Button>(R.id.button2)

        testButton.setOnClickListener{
            val intentTest = Intent(this, UnityPlayerActivity ::class.java)
            startActivity(intentTest)
        }
    }
}
