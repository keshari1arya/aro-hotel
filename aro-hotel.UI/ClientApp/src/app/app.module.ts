import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HotelListComponent } from './hotel/hotel-list/hotel-list.component';
import { HotelDetailsComponent } from './hotel/hotel-details/hotel-details.component';
import { NgbCarouselModule } from '@ng-bootstrap/ng-bootstrap';
import { StoreModule } from '@ngrx/store';
import { appReducer } from './state/app.reducers';
import { AppEffects } from './state/app.effects';
import { EffectsModule } from '@ngrx/effects';
import { LoaderInterceptor } from './interceptor/loader.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HotelListComponent,
    HotelDetailsComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    NgbCarouselModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HotelListComponent, pathMatch: 'full' },
      { path: 'details/:id', component: HotelDetailsComponent },
    ]),
    StoreModule.forRoot({}),
    EffectsModule.forRoot([]),
    StoreModule.forFeature('AppState', appReducer),
    EffectsModule.forFeature([AppEffects]),
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
