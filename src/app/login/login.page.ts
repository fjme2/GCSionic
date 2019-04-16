import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  profileForm = this.fb.group({
    email:['', Validators.compose([Validators.required,Validators.email])],
    password:['',Validators.compose([Validators.required])]
  });
  constructor(private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
  }

  goToHome(){
    this.router.navigateByUrl('tabs/cards');
  }
}
