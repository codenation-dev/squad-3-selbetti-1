import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { SelectionModel } from '@angular/cdk/collections';
import { Log } from 'src/models/log';
import { LogService } from 'src/services/logService';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css'],
  providers: [ LogService ]
})

export class MainComponent implements OnInit  {

  logData: any;

  filter = {
    environment: '',
    searchBy: '',
    search: '',
    arquived: false
  }

  private userData: any;
  private sub: any;

  constructor(public logService: LogService, private router: Router, private route: ActivatedRoute) { }

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  displayedColumns: string[] = ['level', 'environment', 'log', 'date', 'arq', 'det'];
  dataSource = new MatTableDataSource<Log>(this.logData);
 
  getLogs(){
    this.logService.get(this.filter).then((result) => {
      if(result){ 
        this.logData = result
        this.dataSource = new MatTableDataSource<Log>(this.logData);
      }
    },(reject) => { console.log(reject) });
  }

  getById(log: Log){
    this.router.navigateByUrl('/description', { state: { log } });
  }

  arquive(logId){
    this.logService.arquive(logId).then((result) => {
      if(result){ 
      
      }
    },(reject) => { console.log(reject) });
  }

  ngOnInit(){
    this.sub = this.route.params.subscribe(params => {
      this.userData = params;
    })
    this.getLogs();
  }
}