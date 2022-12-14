import { Injectable } from '@angular/core';
import { HotelService } from '../services/hotel.service';
import { createEffect, Actions, ofType } from '@ngrx/effects';
import * as AppActions from './app.actions';
import { exhaustMap, map } from 'rxjs';
import { IHotel } from '../infrastructure/models/hotel';
import { MultimediaService } from '../services/multimedia.service';

@Injectable()
export class AppEffects {
  constructor(private actions$: Actions, private hotelService: HotelService,
    private multimediaService: MultimediaService) { }

  getHotels$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.getHotels),
      exhaustMap((action) =>
        this.hotelService
          .getHotels()
          .pipe(
            map((hotels: IHotel[]) => AppActions.setHotels({ hotels: hotels }))
          )
      )
    )
  );

  getHotelDetails$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.getHotelDetails),
      exhaustMap((action) =>
        this.hotelService
          .getHotelDetails(action.id)
          .pipe(
            map((hotel: IHotel) => AppActions.setHotelDetails({ hotel: hotel }))
          )
      )
    )
  );

  createHotel$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.CreateHotel),
      exhaustMap((action) =>
        this.hotelService
          .createHotel(action.hotel)
          .pipe(
            map((hotel: IHotel) => AppActions.setHotelDetails({ hotel: hotel }))
          )
      )
    )
  );

  uploadFiles$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.uploadImages),
      exhaustMap((action) =>
        this.multimediaService
          .upload(action.file, action.hotelId, action.roomId)
          .pipe(
            map((res) => {
              console.log(res);
              return AppActions.getHotelDetails({ id: +action.hotelId })
            })
          )
      )
    )
  );
}
