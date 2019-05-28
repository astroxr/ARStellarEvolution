package arstellarevolution.com

import android.content.Intent
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val aveStar = findViewById<Button>(R.id.aveStarButton)
        val massStar = findViewById<Button>(R.id.massStarButton)
        val aboutApp = findViewById<Button>(R.id.aboutAppButton)

        // go to other activities
        aveStar.setOnClickListener{
            val intent1 = Intent(this,Activity2::class.java)
            startActivity(intent1)
        }

        massStar.setOnClickListener{
            val intent2 = Intent(this,Activity3::class.java)
            startActivity(intent2)
        }

        aboutApp.setOnClickListener{
            val intent2 = Intent(this,Activity4::class.java)
            startActivity(intent2)
        }
    }
}
