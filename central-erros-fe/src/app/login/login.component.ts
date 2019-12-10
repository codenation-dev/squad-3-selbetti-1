import { Component, OnInit } from '@angular/core';
import { LoginService } from '../../services/loginService';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [LoginService]
})
export class LoginComponent {

  model = {
    mail: '',
    password: ''
  }

  data: any

  constructor(public registerService: LoginService, public router : Router) { }

  doLogin() {
    var login ={
      'Email' : this.model.mail,
      'Password' : this.model.password
    }

    this.registerService.login(login).then((result) => {
      if(result){ 
        this.router.navigate(['/main', result]);
      }
    },(reject) => { console.log(reject) });
  } 
}
