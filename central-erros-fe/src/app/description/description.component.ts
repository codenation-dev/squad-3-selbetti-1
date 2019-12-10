import { Component, OnInit } from '@angular/core';
import { Log } from 'src/models/log';
import { LogService } from 'src/services/logService';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-description',
  templateUrl: './description.component.html',
  styleUrls: ['./description.component.css'],
  providers: [ LogService ]
})
export class DescriptionComponent implements OnInit {

  log: Log;

  constructor(public logService: LogService, public activatedRoute: ActivatedRoute) { }
  
  ngOnInit() {
    this.log = window.history.state;   
  }

}
