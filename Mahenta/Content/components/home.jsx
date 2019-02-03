import { Component, Fragment } from 'react';
import {
	BrowserRouter,
	Route,
	Switch,
	StaticRouter,
	Redirect,
} from 'react-router-dom';

import { Dashboard } from './dashboard.jsx';
import { Donors } from './donors.jsx';
import { Inventory } from './inventory.jsx';
import { Logs } from './logs.jsx';
import { Metrics } from './metrics.jsx';
import { Navbar } from './nav.jsx';
import { Orders } from './orders.jsx';
import { Users } from './users.jsx';

export default class HomeComponent extends Component {
	render() {
		const app = (
			<Fragment>
				<Navbar />
				<Switch>
					<Route
						exact
						path="/"
						render={() => <Redirect to="/dashboard" />}
					/>
					<Route path="/dashboard" component={Dashboard} />
					<Route
						path="/metrics"
						component={Metrics}
					/>
                    <Route path="/inventory" component={Inventory} />
					<Route path="/orders" component={Orders} />
					<Route path="/logs" component={Logs} />
					<Route path="/donors" component={Donors} />
					<Route path="/users" component={Users} />
					<Route
						path="*"
						component={({ staticContext }) => {
							if (staticContext) staticContext.status = 404;

							return <h1>Not Found :(</h1>;
						}}
					/>
				</Switch>
			</Fragment>
		);

		if (typeof window === 'undefined') {
			return (
				<StaticRouter
					context={this.props.context}
					location={this.props.location}
				>
					{app}
				</StaticRouter>
			);
		}
		return <BrowserRouter>{app}</BrowserRouter>;
	}
}
