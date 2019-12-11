import { Component, OnInit } from '@angular/core';
import { Log } from 'src/models/log';
import { LogService } from 'src/services/logService';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-description',
  templateUrl: './description.component.html',
  styleUrls: ['./description.component.css'],
  providers: [ LogService ]
})
export class DescriptionComponent implements OnInit {

  log: Log;

  private userData: any;
  private sub: any;

  constructor(public logService: LogService, public router: Router, public activatedRoute: ActivatedRoute) { }
  
  ngOnInit() {
    /*this.sub = this.activatedRoute.params.subscribe(params => {
      this.userData = params;
    })*/

    this.log = window.history.state;   
  }

}
