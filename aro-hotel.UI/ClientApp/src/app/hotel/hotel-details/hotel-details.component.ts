import { Component, OnInit } from '@angular/core';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css']
})
export class HotelDetailsComponent implements OnInit {
images=[
  'https://photos.smugmug.com/Wallpapers/i-zCPbwbP/0/400d7ea7/X2/HDRshooter-super-ultra-wide-wallpaper-058-X2.jpg',
  'https://photos.smugmug.com/Wallpapers/i-hGrfc7s/0/36e055d7/X2/HDRshooter-super-ultra-wide-wallpaper-056-X2.jpg',
  'https://static.bhphotovideo.com/explora/sites/default/files/styles/960/public/30841-ts.png?itok=QN1Q9Huq'
]
  constructor(private hotelService:HotelService) { }

  ngOnInit(): void {
    this.hotelService.getHotelDetails(1).subscribe(x=>console.log(x));
  }

}
