import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Pod } from '../types/types';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class PodServiceService {

  private apiUrl:string =environment.apiUrl
  constructor(
    private HttpClient: HttpClient
  ) { }

  listar():Observable<Pod[]>{
    return this.HttpClient.get<Pod[]>(`${this.apiUrl}/Pod`);
  }
}
