import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Register } from 'src/models/register';
import { Login } from 'src/models/login';

const httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
};

const url = 'https://localhost:44385/api/users';

@Injectable()
export class RegisterService {

    constructor(public http: HttpClient) {
        console.log('Hello RegisterService Provider');
    }

    save(user) {
        let body = JSON.stringify(user);

        let promise = this.http.post<Register>(url + '/Register', body, httpOptions);

        return promise.toPromise();
    }
}