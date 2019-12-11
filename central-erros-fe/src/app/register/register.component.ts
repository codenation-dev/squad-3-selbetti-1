import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../../services/RegisterService';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [RegisterService]
})
export class RegisterComponent {

  model = {
    id: null,
    name: '',
    mail: '',
    password: '',
    nameApp: '',
    ip: '',
    url: ''
  }

  constructor(public registerService: RegisterService) { }

  save() {
    var register ={
      'Name' : this.model.name,
      'Email' : this.model.mail,
      'Password' : this.model.password,
      'NameApp' : this.model.nameApp,
      'Ip' : this.model.ip,
      'Url' : this.model.url
    }
    
    this.registerService.save(register);
  }
}
