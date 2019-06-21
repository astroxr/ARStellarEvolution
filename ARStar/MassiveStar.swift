//
//  MassiveStar.swift
//  ARStar
//
//  Created by ual-laptop on 6/17/19.
//  Copyright © 2019 AstroCardboard. All rights reserved.
//

import UIKit

class MassiveStar: UIViewController {

    @IBOutlet weak var phaseNumber2: UITextField!
    
    @IBOutlet weak var starImage2: UIImageView!
    
    @IBOutlet var descPhase2: UITextView!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }
    

    @IBAction func changeSlider2(_ sender: UISlider) {
        if(sender.value < 1){
            phaseNumber2.text = "Phase 1"
            descPhase2.text = "Huge clouds of dust and gases exist in space."
            starImage2.image = UIImage(named: "nebulacloud")
        }
        else if(sender.value < 2){
            phaseNumber2.text = "Phase 2"
            descPhase2.text = "The dust and gases are attracted to each other by their own gravity and getting denser and hotter until they fused together form a star."
            starImage2.image = UIImage(named: "massivestar")
        }
        else if(sender.value < 3){
            phaseNumber2.text = "Phase 3"
            descPhase2.text = "After the star has run out of hydrogen, it will lose its hydrostatic equilibrium and it is going to collapse again until the heliums themselves will be used as an energy source, which will then expand the star even more."
            starImage2.image = UIImage(named: "redsupergiant")
        }
        else if(sender.value < 4){
            phaseNumber2.text = "Phase 4"
            descPhase2.text = "The star expand so much that its outer atmosphere drifted out from the star in a process called supernova explosion."
            starImage2.image = UIImage(named: "nebulacloud")
        }
        else {
            phaseNumber2.text = "Phase 5"
            descPhase2.text = "The remnants of the massive star is the black hole, which is the core of the star. It is incredibly dense and hot."
            starImage2.image = UIImage(named: "blackhole")
        }
    }
    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */

}
