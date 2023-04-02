import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthserviceService } from 'src/app/services/authservice.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.scss']
})
export class AdminDashboardComponent implements OnInit {
  uName = localStorage.getItem('uName');
  constructor(private authService: AuthserviceService, private route: Router) { }

  ngOnInit(): void {
  }

  logOut(){
    this.authService.logOut();
    this.route.navigateByUrl('/home');
  }
}

