import { Component } from '@angular/core'
import { Product, ProductService } from './product.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'my-first-project'

  products?: Product[]

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService
      .getProductsSmall()
      .subscribe((data) => (this.products = data))
  }
}
