package arstellarevolution.com

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.SeekBar
import kotlinx.android.synthetic.main.activity_3.*

class Activity3 : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_3)

        //initialize variables
        val images = arrayOf(R.drawable.abc_action_bar_item_background_material,
            R.drawable.massivestar,R.drawable.redsupergiant)
        val seekBar2 = findViewById<SeekBar>(R.id.seekBar2)

        //change view as seek bar changes
        seekBar2.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onStopTrackingTouch(seekBar: SeekBar?) {
            }

            override fun onStartTrackingTouch(seekBar: SeekBar?) {
            }

            override fun onProgressChanged(seekBar2: SeekBar?, progress: Int, fromUser: Boolean) {
                if (seekBar2 != null) {
                    if (progress == 0) {
                        textView2.text = "Phase 1"
                        imageView2.setImageResource(images[0])
                    }else if (progress == 1){
                        textView2.text = "Phase 2"
                        imageView2.setImageResource(images[1])
                    }else if (progress == 2){
                        textView2.text = "Phase 3"
                        imageView2.setImageResource(images[2])
                    }else if (progress == 3){
                        textView2.text = "Phase 4"
                        imageView2.setImageResource(images[0])
                    }else if (progress == 4){
                        textView2.text = "Phase 5"
                        imageView2.setImageResource(images[0])
                    }
                }
            }

        }
        )

    }

}
