//
//  AverageStar.swift
//  ARStar
//
//  Created by ual-laptop on 6/17/19.
//  Copyright © 2019 AstroCardboard. All rights reserved.
//

import UIKit

class AverageStar: UIViewController {
    
    @IBOutlet weak var phaseNumber: UITextField!
    
    @IBOutlet weak var starImage: UIImageView!
    
    @IBOutlet var descPhase: UITextView!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }
    
    @IBAction func changeSlider(_ sender: UISlider) {
        if(sender.value < 1){
            phaseNumber.text = "Phase 1: Nebula"
            descPhase.text = "Huge clouds of dust and gases exist in space."
            starImage.image = UIImage(named: "nebulacloud")
        }
        else if(sender.value < 2){
            phaseNumber.text = "Phase 2: Average Star"
            descPhase.text = "The dust and gases are attracted to each other by their own gravity and getting denser and hotter until they fused together form a star."
            starImage.image = UIImage(named: "lowmassstar")
        }
        else if(sender.value < 3){
            phaseNumber.text = "Phase 3: Red Giant"
            descPhase.text = "After the star has run out of hydrogen, it will lose its hydrostatic equilibrium and it is going to collapse again until the heliums themselves will be used as an energy source, which will then expand the star even more."
            starImage.image = UIImage(named: "redgiant")
        }
        else if(sender.value < 4){
            phaseNumber.text = "Phase 4: Supernova"
            descPhase.text = "The star expand so much that its outer atmosphere drifted out from the star in a process called supernova explosion."
            starImage.image = UIImage(named: "nebulacloud")
        }
        else {
            phaseNumber.text = "Phase 5: White Dwarf"
            descPhase.text = "The remnants of the average star is the white dwarf, which is the core of the star. It is incredibly dense and hot."
            starImage.image = UIImage(named: "whitedwarf")
        }
    }

}
