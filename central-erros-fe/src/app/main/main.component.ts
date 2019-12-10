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

  displayedColumns: string[] = ['level', 'log', 'date', 'arq', 'det'];
  dataSource = new MatTableDataSource<Log>(this.logData);
 // selection = new SelectionModel<Log>(true, []);

  /** Whether the number of selected elements matches the total number of rows. */
 /* isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }*/

  /** Selects all rows if they are not all selected; otherwise clear selection. */
 /* masterToggle() {
    this.isAllSelected() ?
        this.selection.clear() :
        this.dataSource.data.forEach(row => this.selection.select(row));
  }*/

  /** The label for the checkbox on the passed row */
 /* checkboxLabel(row?: Log): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.position + 1}`;
  }
*/
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

  delete(item){
    this.logService.deleteById(item).then((result) => {
      if(result){ 
        console.log('Excluído com sucesso!!');        
      }
    },(reject) => { console.log(reject) });
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