import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ApiUrls } from "../infrastructure/url";

@Injectable({
  providedIn: 'root'
})
export class MultimediaService {

  constructor(private http: HttpClient) { }

  upload(files: File[], hotelId: string, roomId: string) {
    const formData = new FormData();
    files.forEach(file => formData.append(file.name, file));
    formData.append('hotelId', hotelId);
    formData.append('roomId', roomId);
    return this.http.post(ApiUrls.upload, formData);
  }
}
