package arstellarevolution.com

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.SeekBar
import kotlinx.android.synthetic.main.activity_2.*

class Activity2 : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_2)

        //initialize variables
        val images = arrayOf(R.drawable.nebulacloud,
            R.drawable.lowmassstar,R.drawable.redgiant,R.drawable.whitedwarf)
        val seekBar = findViewById<SeekBar>(R.id.seekBar)

        //change view as seek bar changes
        seekBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onStopTrackingTouch(seekBar: SeekBar?) {
            }

            override fun onStartTrackingTouch(seekBar: SeekBar?) {
            }

            override fun onProgressChanged(seekBar: SeekBar?, progress: Int, fromUser: Boolean) {
                if (seekBar != null) {
                    if (progress == 0) {
                        textView.text = "Phase 1"
                        imageView.setImageResource(images[0])
                    }else if (progress == 1){
                        textView.text = "Phase 2"
                        imageView.setImageResource(images[1])
                    }else if (progress == 2){
                        textView.text = "Phase 3"
                        imageView.setImageResource(images[2])
                    }else if (progress == 3){
                        textView.text = "Phase 4"
                        imageView.setImageResource(images[0])
                    }else if (progress == 4){
                        textView.text = "Phase 5"
                        imageView.setImageResource(images[3])
                    }
                }
            }

        }
        )
    }
}
