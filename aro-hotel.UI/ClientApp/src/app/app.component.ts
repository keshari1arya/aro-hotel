import { AfterViewChecked, ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { LoaderService } from './services/loader.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'app';
  loading = false;
  constructor(public loader: LoaderService, private cdr: ChangeDetectorRef,) {}
  ngOnInit(): void {
    this.loader.isLoading$.subscribe((loading) => {
      this.loading = loading;
      this.cdr.detectChanges();
    });
  }
}
