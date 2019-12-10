import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Log } from 'src/models/log';

const httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
};

const url = 'http://localhost:4200/assets/api/log/log.json';

@Injectable()
export class LogService {

    constructor(public http: HttpClient) {
        console.log('Hello UserService Provider');
    }

    //mostra informações na table
    get(filter) {
      let promise = this.http.get<Log>(url, filter);
      return promise.toPromise();
    }

    //mostra informação do log no detalhamento
    getByid(logId) {
      let promise = this.http.get<Log>(url, logId);
      return promise.toPromise();
    }

    deleteById(logId) {
      let promise = this.http.delete<Log>(url, logId);
      return promise.toPromise();
    }

    arquive(log){
      let promise = this.http.put<Log>(url, log);
      return promise.toPromise();
    }
}