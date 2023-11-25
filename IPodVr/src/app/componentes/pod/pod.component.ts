import { Component, OnInit } from '@angular/core';
import { PodServiceService } from 'src/app/Core/services/pod-service.service';
import { Pod } from '../../Core/types/types';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-pod',
  templateUrl: './pod.component.html',
  styleUrls: ['./pod.component.css']
})
export class PodComponent implements OnInit {

  podsList$!:Observable<Pod[]>;

  constructor(private service:PodServiceService) {
    
  }

  
  ngOnInit(): void {
    this.podsList$=this.service.listar()
  }


}
