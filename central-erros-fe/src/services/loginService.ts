import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Login } from 'src/models/login';

const httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
};

const url = 'https://localhost:44385/api/users';

@Injectable()
export class LoginService {

    constructor(public http: HttpClient) {
        console.log('Hello LoginService Provider');
    }
    
    login(credentials) {
        let body = JSON.stringify(credentials);

        let promise = this.http.post<Login>(url + '/Authenticate', body, httpOptions);

        return promise.toPromise();
    }   
}